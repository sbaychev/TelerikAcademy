using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobPhoneClass
{
//Define a class that holds information about a mobile phone device: model, 
//manufacturer, price, owner, battery characteristics (model, hours idle and hours
//talk) and display characteristics (size and number of colors). Define 3 separate
//classes (class GSM holding instances of the classes Battery and Display).

//Define several constructors for the defined classes that take different sets of 
//arguments (the full information for the class or part of it). Assume that model 
//and manufacturer are mandatory. All unknown data fill with null.
//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field 
//for the batteries.

//Add a method in the GSM class for displaying all information about it. Try to override ToString().
//Use properties to encapsulate data fields inside the GSM, Battery and Display classes. 
//Ensure all fields hold correct data at any given time.
//Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.
//Create a class Call to hold a call performed through a GSM. It should contain date, time, 
//dialed phone number and duration (in seconds).
//Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to 
//use the system class List<Call>.
//Add methods in the GSM class for adding and deleting calls from the calls history. 
//Add a method to clear the call history.
//Add a method that calculates the total price of the calls in the call history. 
//Assume the price per minute is fixed and is given as parameter.
//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class. Add few calls. Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the 
//calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.

    class GSM
    {
        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        //local variables
        private string mobPhonModel;
        private string mobPhonMaker;
        private float mobPhonPrice;
        private string mobPhonOwner;

        private static GSM iPhone = new GSM("iPhone", "Apple", 100, "me",new Battery("1500 mAh",BatteryType.NiMH), new Display(4, 5000));

        public Battery bat = new Battery();
        public Display displ = new Display();

        //model, manufacturer, price, owner - Properties
        //Ensure all fields hold correct data at any given time.
        public string MobPhonModel
        {
            get { return this.mobPhonModel; }
            private set
            {
                if (value.Length >= 0)
                {
                    this.mobPhonModel = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string MobPhonMaker
        {
            get { return this.mobPhonMaker; }
            private set
            {
                if (value.Length >= 0)
                {
                    this.mobPhonMaker = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public float MobPhonPrice
        {
            get { return this.mobPhonPrice; }
            private set
            {
                if (value >= 0)
                {
                    this.mobPhonPrice = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string MobPhonOwner
        {
            get { return this.mobPhonOwner; }
            private set
            {
                if (value.Length >= 0)
                {
                    this.mobPhonOwner = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public static GSM IPhone 
        {
            get { return iPhone; }
        }
        //Define several constructors for the defined classes that take different sets of 
        //arguments (the full information for the class or part of it). Assume that model 
        //and manufacturer are mandatory. All unknown data fill with null.
        private List<Call> callHistory = new List<Call>();
       //the full Constructor - the others are based on it
        public GSM(string model, string maker, float price, string owner, Battery battery, Display display)
        {
            MobPhonModel = model;
            MobPhonMaker = maker;
            MobPhonPrice = price;
            MobPhonOwner = owner;
            this.bat = battery;
            this.displ = display;
        }
        //The other constructors, plus the default one
        public GSM() : this(null, null, 0, null, null, null) { }
        public GSM(string model, string maker) : this(model,maker,0,null, null, null)   { }
        public GSM(string model, string maker, float price) : this(model, maker, price, null, null, null) { }
        public GSM(string model, string maker, string owner) : this(model, maker, 0, owner, null, null) { }
        //Add a method in the GSM class for displaying all information about it. Try to override ToString().
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}  {4}\t{5}\t{6}\t{7}\t{8}\t{9}", 
                MobPhonModel, MobPhonMaker, MobPhonPrice, MobPhonOwner, bat.BatteryModel, bat.BatType, bat.IdleTime, bat.TalkTime,
                displ.DisplNumColors, displ.DisplSize);
        }
        //Add methods in the GSM class for adding and deleting calls from the calls history. 
        //Add a method to clear the call history.
        //Add a method that calculates the total price of the calls in the call history. 
        //Assume the price per minute is fixed and is given as parameter.
        public void AddCall(DateTime now, string callNumber, int durationTime)
        {
            Call call = new Call(now, callNumber, durationTime);
            callHistory.Add(call);
        }
        public void DeleteCallByDuration(int duration)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].DurationCall == duration)
                {
                    callHistory.RemoveAt(i);
                    i--;
                }
            }
        }
        public void ClearCallHistory()
        {
            callHistory.Clear();
        }
        public void DisplayCallHistory()
        {
            StringBuilder callDirectory = new StringBuilder();
            callDirectory.AppendLine("PHONE CALL HISTORY");
            foreach (var call in callHistory)
            {
                callDirectory.AppendFormat("Phone Number: {0}, Date: {1}, Duration: {2}\n", call.DialledNumber, call.DateTime, call.DurationCall);
            }
            Console.WriteLine();
            Console.WriteLine(callDirectory.ToString());
        }
        public double CalcPrice(double pricePerMin)
        {
            double totalTime = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                totalTime = totalTime + callHistory[i].DurationCall;
            }
            double price = pricePerMin * (Math.Ceiling(totalTime / 60));
            return price;
        }
    }
    public enum BatteryType { LiIon, NiMH, NiCd };
    class Battery
    {
        //All unknown data fill with null.
        //Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field 
        //for the batteries.

        //local variables
        private string batteryModel;
        private float idleTime;
        private float talkTime;
        private BatteryType batType;

        //Properties
        //Ensure all fields hold correct data at any given time.
   
        public string BatteryModel
        {
            get { return this.batteryModel; }
            private set
            {
                this.batteryModel = value;
            }
        }
        public float IdleTime
        {
            get { return this.idleTime; }
            private set
            {
                if (value >= 0)
                {
                    this.idleTime = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public float TalkTime
        {
            get { return this.talkTime; }
            private set
            {
                if (value >= 0)
                {
                    this.talkTime = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public BatteryType BatType  
        {
            get { return this.batType; }
            private set
            {
                if (!(Enum.IsDefined(typeof(BatteryType), value)))
                {
                    throw new ArgumentException("The value you have entered is not defined!");
                }
                this.batType = value;
            }
        }

        //Constructors

        //the full Constructor - the others are based on it
        public Battery(string batMod, float idlTime, float tlkTime, BatteryType battType)
        {
            BatteryModel = batMod;
            IdleTime = idlTime;
            TalkTime = tlkTime;
            BatType = battType;
        }
        //The other constructors, plus the default one
        public Battery() : this(null, 0, 0, 0) { }
        public Battery(string batMod, float idlTime) : this(batMod, idlTime, 0, 0) { }
        public Battery(string batMod, float idlTime, float tlkTime) : this(batMod, idlTime, tlkTime, 0) { }      
        public Battery(string batMod, BatteryType batType) : this(batMod, 0, 0, batType) { }
        public Battery(string batMod, float tlkTime, BatteryType batType) : this(batMod, 0, tlkTime, batType) { }
    }
    class Display   
    {
        //local variables
        private float displSize;
        private int displNumColors;
        //Properties
        //Ensure all fields hold correct data at any given time.
        public float DisplSize
        {
            get { return this.displSize; }
            private set
            {
                if (value >= 0)
                {
                    this.displSize = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public int DisplNumColors
        {
            get { return this.displNumColors; }
            private set
            {

                if (value >= 0)
                {
                    this.displNumColors = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //Constructors
        //the full Constructor - the others are based on it
        public Display(float displaySize, int displayNumCol)
        {
            DisplSize = displaySize;
            DisplNumColors = displayNumCol;
        }
        //The other constructors, plus the default one
        public Display() : this (0, 0){ }
        public Display(float displaySize) : this(displaySize, 0) { }
        public Display(int displayNumCol) : this(0, displayNumCol) { }
    }
    class Call
    {
        private DateTime dateTime;
        private string dialledNumber;
        private int durationCall;

        // Constructor
        public Call(DateTime dateAndTime, string dialedNumber, int duration)
        {
            DateTime = dateAndTime;
            DialledNumber = dialedNumber;
            DurationCall = duration;
        }
        // Properties
        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }

            private set
            {
                this.dateTime = value;
            }
        }
        public string DialledNumber
        {
            get
            {
                return this.dialledNumber;
            }

            private set
            {
                this.dialledNumber = value;
            }
        }
        public int DurationCall
        {
            get
            {
                return this.durationCall;
            }
            private set
            {
                this.durationCall = value;
            }
        }
    }
    //Write a class GSMTest to test the GSM class
    //Create an array of few instances of the GSM class
    class GSMTest
    {        
        static void Main()
        {
           GSM[] array = 
            { 
                new GSM("Nokia","Nokia",100,"you", new Battery("1200 mAh",BatteryType.LiIon), new Display(12, 1000)),
                new GSM("Samsung","Samsung",200,"me", new Battery("1100 mAh",BatteryType.NiCd), new Display(5, 2000)),
                new GSM("Unknown","Unknown",300,"you", new Battery("1400 mAh",BatteryType.NiMH), new Display(4, 5000))
            };
           
            foreach (var phone in array)
            {
                Console.WriteLine(phone);
            }
            //Display the information about the static property IPhone4S.
            Console.WriteLine();
            Console.WriteLine(GSM.IPhone);

            //the "class" GSMCallHistoryTest - just for testing purposes as per required
            //Create an instance of the GSM class.
            //Add few calls.
            //Display the information about the calls.
            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            //Remove the longest call from the history and calculate the total price again.
            //Finally clear the call history and print it.
            GSM testPhone = new GSM("HTC", "HTC Corp", 120, "mine", new Battery("1200 mAh", BatteryType.LiIon), new Display(12, 1000));

            testPhone.AddCall(DateTime.Now, "0892222222", 12);
            testPhone.AddCall(DateTime.Now, "0892222266", 111);
            testPhone.AddCall(DateTime.Now, "0892222255", 222);

            testPhone.DisplayCallHistory();
            Console.Write("The total price of the calls in the history: {0}", testPhone.CalcPrice(0.37));
            Console.WriteLine();

            testPhone.DeleteCallByDuration(222);

            testPhone.DisplayCallHistory();
            Console.Write("The total price of the calls in the history: {0}", testPhone.CalcPrice(0.37));
            Console.WriteLine();

            testPhone.ClearCallHistory();
            testPhone.DisplayCallHistory();//to show that the records are clear
        }
    }
}