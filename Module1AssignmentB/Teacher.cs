namespace us.mattgreen{

    /**
 * Created by mgreen14 on 12/27/17.
 */
    public class Teacher : Person, Talkable {
        private int age;

        public Teacher(int age, string name): base(name) {
            this.age = age;
        }

        public int getAge() {
            return age;
        }

        public void setAge(int age) {
            this.age = age;
        }

        public string talk() {
            return "Don't forget to do the assigned reading!";
        }
    }
}