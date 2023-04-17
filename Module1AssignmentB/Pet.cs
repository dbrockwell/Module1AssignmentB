namespace us.mattgreen{

    /**
 * Created by mgreen14 on 12/27/17.
 */
    public abstract class Pet {
        protected string name;

        public Pet(string name) {
            this.name = name;
        }

        public string getName() {
            return name;
        }
    }
}