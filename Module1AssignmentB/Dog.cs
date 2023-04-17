namespace us.mattgreen{

    /**
 * Created by mgreen14 on 12/27/17.
 */
    public class Dog : Pet, Talkable {
        private bool friendly;

        public Dog(bool friendly, string name): base(name) {
            this.friendly = friendly;
        }

        public bool isFriendly() {
            return friendly;
        }
        
        public string talk() {
            return "Bark";
        }

        public string toString() {
            return "Dog: " + "name=" + name + " friendly=" + friendly;
        }
    }
}