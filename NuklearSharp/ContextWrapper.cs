﻿using System;
using System.Runtime.InteropServices;

namespace NuklearSharp
{
	public unsafe partial class ContextWrapper
	{
		private readonly Nuklear.nk_context _ctx;
		private readonly Nuklear.nk_buffer _cmds;
		private readonly IRenderer _renderer;

		public Nuklear.nk_context Ctx
		{
			get { return _ctx; }
		}

		public Nuklear.nk_buffer Cmds
		{
			get { return _cmds; }
		}

		public IRenderer Renderer
		{
			get { return _renderer; }
		}

		public ContextWrapper(IRenderer renderer)
		{
			if (renderer == null)
			{
				throw new ArgumentNullException("renderer");
			}

			_ctx = new Nuklear.nk_context();
			_cmds = new Nuklear.nk_buffer();
			Nuklear.nk_init_default(_ctx, null);
			Nuklear.nk_buffer_init_default(_cmds);

			_renderer = renderer;
		}

		public FontAtlasWrapper CreateFontAtlas()
		{
			return new FontAtlasWrapper(_renderer);
		}

		public void SetFont(Nuklear.nk_font font)
		{
			Nuklear.nk_style_set_font(_ctx, font.handle);
		}

		public void Draw()
		{
			_renderer.BeginDraw();

			var vbuf = new Nuklear.nk_buffer();
			var ebuf = new Nuklear.nk_buffer();
			Nuklear.nk_draw_command* cmd;
			//  ushort* offset = null;
			var config = new Nuklear.nk_convert_config
			{
				vertex_size = (uint) sizeof (NkVertex),
				vertex_alignment = 4,
				global_alpha = 1f,
				shape_AA = Nuklear.NK_ANTI_ALIASING_ON,
				line_AA = Nuklear.NK_ANTI_ALIASING_ON,
				circle_segment_count = 22,
				curve_segment_count = 22,
				arc_segment_count = 22,
				vertex_layout = new[]
				{
					new Nuklear.nk_draw_vertex_layout_element
					{
						attribute = Nuklear.NK_VERTEX_POSITION,
						format = Nuklear.NK_FORMAT_FLOAT,
						offset = 0
					},
					new Nuklear.nk_draw_vertex_layout_element
					{
						attribute = Nuklear.NK_VERTEX_COLOR,
						format = Nuklear.NK_FORMAT_B8G8R8A8,
						offset = 12
					},
					new Nuklear.nk_draw_vertex_layout_element
					{
						attribute = Nuklear.NK_VERTEX_TEXCOORD,
						format = Nuklear.NK_FORMAT_FLOAT,
						offset = 16
					},
					new Nuklear.nk_draw_vertex_layout_element
					{
						attribute = Nuklear.NK_VERTEX_ATTRIBUTE_COUNT
					}
				}
			};

			/* convert shapes into vertexes */
			Nuklear.nk_buffer_init_default(vbuf);
			Nuklear.nk_buffer_init_default(ebuf);

			Convert(_cmds, vbuf, ebuf, config);

			var vSize = (ulong) sizeof (NkVertex);

			var vertex_count = (uint) (vbuf.needed/vSize);
			var vertices = new byte[(int) vbuf.needed];
			var indices = new short[ebuf.needed/sizeof (short)];

			Marshal.Copy((IntPtr) vbuf.memory.ptr, vertices, 0, (int) vbuf.needed);

			/* iterate over and execute each draw command */
			uint offset = 0;

			Marshal.Copy((IntPtr) ebuf.memory.ptr, indices, 0, indices.Length);

			_renderer.SetBuffers(vertices, indices, (int) vertex_count, sizeof (NkVertex));
			for (cmd = Nuklear.nk__draw_begin(_ctx, _cmds); (cmd) != null; (cmd) = Nuklear.nk__draw_next(cmd, _cmds, _ctx))
			{
				if (cmd->elem_count == 0) continue;

				_renderer.Draw((int) cmd->clip_rect.x, (int) cmd->clip_rect.y, (int) cmd->clip_rect.w, (int) cmd->clip_rect.h,
					cmd->texture.id, (int) offset, (int) (cmd->elem_count/3));
				offset += cmd->elem_count;
			}
			Nuklear.nk_buffer_free(vbuf);
			Nuklear.nk_buffer_free(ebuf);
			Nuklear.nk_clear(_ctx);

			_renderer.EndDraw();
		}
	}
}