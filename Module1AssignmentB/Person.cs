namespace us.mattgreen{

    /**
 * Created by mgreen14 on 12/27/17.
 */
    public abstract class Person {
        private string name;

        public Person(string name) {
            this.name = name;
        }

        public string getName() {
            return name;
        }

        public void setName(string name) {
            this.name = name;
        }
    }
}