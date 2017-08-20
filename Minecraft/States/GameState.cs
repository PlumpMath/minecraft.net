using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.States {
    abstract class GameState {
        public GameState (Application app) {

        }

        public abstract void Input();
        public abstract void Update();
        public abstract void Draw();
    }
}
