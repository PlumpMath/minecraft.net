using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Minecraft.States {
    class PlayingState : GameState {
        private Model model;

        public PlayingState(Application app) : base(app) {
            var vertices = new Vector2[] {
                new Vector2(-0.5f, +0.5f),
                new Vector2(+0.5f, -0.5f),
                new Vector2(-0.5f, -0.5f),
                new Vector2(-0.5f, +0.5f),
                new Vector2(+0.5f, +0.5f),
                new Vector2(+0.5f, -0.5f)
            };

            model = new Model(vertices);
        }

        public override void Draw() {
            model.Bind();

            //GL.DrawElements(BeginMode.Triangles, 6, DrawElementsType.UnsignedInt, IntPtr.Zero);

            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

            model.UnBind();
        }

        public override void Input() {
            throw new NotImplementedException();
        }

        public override void Update() {
            throw new NotImplementedException();
        }
    }
}
