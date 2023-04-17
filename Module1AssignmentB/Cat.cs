namespace us.mattgreen{

    /**
 * Created by mgreen14 on 12/28/17.
 */
    public class Cat : Pet, Talkable {
        private int mousesKilled;

        public Cat(int mousesKilled, string name): base(name) {
            this.mousesKilled = mousesKilled;
        }

        public int getMousesKilled() {
            return mousesKilled;
        }

        public void addMouse() {
            mousesKilled++;
        }
        
        public string talk() {
            return "Meow";
        }
        
        public string toString() {
            return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
        }
    }
}