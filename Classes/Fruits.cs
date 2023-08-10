   namespace BEK.Classes
{ 
 
    class Fruit 
    {
       public int price;

       public string name;

       public int quantity;
    
    public Fruit()
    {
         price = 0;
         name = "";
         quantity = 0;

    }
    public Fruit(int price, string name, int quantity)
    {
        this.price = price;
        this.name = name;
        this.quantity = quantity;
    }


       public int Price 
       { 
        get
        {
            return price;
        }

        set
        {
            price = value;
        } 
        }
       public string Name 
       { 
        get
        {
            return name;
        } 
        
        set
        {
            name = value;    
        } 
        }
       public int Quantity
        { 
            get
            {
                return quantity;
            } 
            set
            {
                    quantity = value;
            } 
            }

    }

    class Vegetable
    {
         public int price;
         public string name;
         public int quantity;
         public int oldingiMiqdor;
         public int sotilganMiqdor;

        public Vegetable()
        {
             name = "";
             price = 0;
             quantity = 1;
             oldingiMiqdor = 0;
             sotilganMiqdor = 0;
        }

        public Vegetable (string nomi, int miqdorHozirgi, int sotilgan )
        {
            Name = nomi;
            Quantity = miqdorHozirgi;
            sotilganMiqdor = sotilgan;
            oldingiMiqdor = Quantity + sotilganMiqdor;

        }





        public int Price  
        { 
            get
            {
                return price;
            } 
            set
            {
                price = value;
            }
        }

        public string  Name 
        { 
            get
            {
                return name;
            } 
            set
            {
                name = value;
            } 
        }

        public int Quantity 
        {
           get
           {
            return quantity;
           } 
           set
           {
                quantity = value;
           } 
        }
    }

    class Flower
    {
            public int price;
            public string name;
            public int quantity;
            public string place;
            public int qoldi;
            public int resultDifference;
            public int firstCount;

            public Flower()
            {
                name = "";
                place = "";
                price = 0;
                quantity = 0;
                qoldi = 0;
                resultDifference = 0;
                firstCount = 0;

            }

            public Flower (int shunchaQoldi, int firstCount)
            {
                qoldi = shunchaQoldi;
                resultDifference = firstCount - shunchaQoldi;
            }

        public int Price 
        {
              get
            {
                    return price;   
            }
              set
            {
                    price = value;
            } 
        }

        public string  Name 
        {
             get
             {
                    return name;
             } 
             set
             {
                    name = value;   
             } 
        }

        public int Quantity 
        {
              get
            {
                    return quantity;    
            }
              set
            {
                    quantity = value;
            } 
        }

        public string Place 
        {
             get
             {
                    return place;
             } 
             set
             {
                    place = value;
             } 
        }
    }

    class Animal
    {
                public int quantity;
                public string name;
                public string place;
                public int age;
                public int AgeDifference;

public Animal()
{
    name = "";
    place = "";
    age = 0;
    quantity = 0;
    AgeDifference = 0;
}

public Animal(string myname,int userage, int animalAge)
{
    Name = myname;
    Age = animalAge;
    AgeDifference = userage - animalAge;
}

        public int Quantity 
        {
             get
             {
                    return quantity;
             } 
             set
             {
                    quantity = value;
             } 
        }

        public string  Name 
        {
             get
             {
                    return name;          
             } 
             set
             {
                    name = value;
             } 
        }

        public string  Place 
        {
             get
             {
                return place;
             } 
             set
             {
                place = value;
             } 
        }

         public int Age 
        { 
             get
             {
                return age;
             } 
             set
             {
                age = value;
             } 
        }
    }


}