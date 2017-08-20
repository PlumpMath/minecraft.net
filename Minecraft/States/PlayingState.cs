using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.States {
    class PlayingState : GameState {
        private Model model;
        private OpenGL gl;

        public PlayingState(Application app) : base (app) {
            var vertices = new float[] {
                0.5F, 0.5F,
                -0.5F, 0.5F,
                -0.5F, -0.5F,
                -0.5F, -0.5F,
                0.5F, -0.5F,
                0.5F, 0.5F
            };

            model = new Model(app.OpenGL, vertices);

            gl = app.OpenGL;
        }

        public override void Draw() {
            model.Bind();

            gl.DrawArrays(OpenGL.GL_TRIANGLES, 0, 6);

            model.UnBind();
        }

        public override void Input() {

        }

        public override void Update() {

        }
    }
}
