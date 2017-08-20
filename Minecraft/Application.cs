using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpGL;

using Minecraft.States;

namespace Minecraft {
    class Application {
        public OpenGL OpenGL { get; private set; }

        public Display Display { get; private set; }

        private Stack<GameState> states;

        public Application(Display display) {
            Display = display;

            OpenGL = new OpenGL();

            states = new Stack<GameState>();
        }

        public void RunMainGameLoop() {
            while (Display.IsOpen()) {
                Display.ProcessEvents();

                // Do stuff with the states.
                var current = states.Peek();

                current.Input();
                current.Update();
                current.Draw();

                Display.Clear();
                Display.Update();
            }
        }

        public void PushState(GameState state) {
            states.Push(state);
        }

        public void PopState() {
            states.Pop();
        }
    }
}
