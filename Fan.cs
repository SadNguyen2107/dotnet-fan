namespace SN_Program
{
    class Fan
    {
        // Dictionary to check the fan status
        public static Dictionary<string, Byte> FanStatus = new Dictionary<string, byte>()
        {
            {"SLOW", 1},
            {"MEDIUM", 2},
            {"FAST", 3},
        };

        // Fan Attribute
        private int speed;
        private bool isOn = false;
        private double radius = 5.0;
        private string color = "blue";

        // GETTER - SETTER
        public int Speed
        {
            get { return this.speed; }
            set
            {
                if (value < 0)
                {
                    this.speed = 0;
                    return;
                }
                this.speed = value;
            }
        }

        public bool IsOn
        {
            get { return this.isOn; }
        }
        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    this.radius = 0;
                    return;
                }
                this.radius = value;
            }
        }
        public string Color
        {
            get { return this.color; }
            set
            {
                if (value != String.Empty)
                {
                    this.color = value;
                }
            }
        }

        public Fan(int speed, double radius, string color, bool isOn = false)
        {
            this.Speed = speed;
            this.Radius = radius;
            this.Color = color;
            this.isOn = isOn;
        }

        public override string ToString()
        {
            if (!this.isOn)
            {
                return $"Fan is OFF with:  \nSpeed: {this.speed} \nRadius: {this.radius} \nColor: {this.color}";
            }

            return $"Fan is ON with: \nSpeed: {this.speed} \nRadius: {this.radius} \nColor: {this.color}";
        }

    }
}