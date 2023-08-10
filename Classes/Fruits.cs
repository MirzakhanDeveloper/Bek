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

        public Vegetable()
        {
            name = "";
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

            public Flower()
            {
                name = "";
                place = "";
                price = 0;
                quantity = 0;
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

public Animal()
{
    name = "";
    place = "";
    age = 0;
    quantity = 0;
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