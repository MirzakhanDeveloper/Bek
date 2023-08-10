   namespace BEK.Classes
{ 
 
    class Fruit 
    {
         public int price;
         public string name;
         public int quantity;
         public int result;
    
         public Fruit()
        {
         name = "";
         price = 0;
         quantity = 0;
         result = 0;
        }

        public Fruit (string nomi,int narxi, int miqdori )
        {
                Name = nomi;
                Price = narxi;
                Quantity = miqdori;
                resultAllFruitsNoReturnValue(Price,Quantity);
        }  

        private int resultAllFruits(int Price, int Quantity)
        {
           return Price * Quantity;
        }

        private void resultAllFruitsNoReturnValue(int Price, int Quantity)
        {
            result = Price * Quantity;
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
         public int sotilganMiqdor;
         public int resultVegetable;

        public Vegetable()
        {
             name = "";
             price = 0;
             quantity = 1;
             resultVegetable = 0;

        }

        public Vegetable (string nomi, int miqdorHozirgi, int sotilgan )
        {
            Name = nomi;
            Quantity = miqdorHozirgi;
            sotilganMiqdor = sotilgan;
            //resultVegetable = oldingiMiqdor(Quantity,sotilganMiqdor);
            oldingiMiqdorNoReturn(Quantity,sotilganMiqdor);
        }

        private int oldingiMiqdor(int Quantity, int sotilganMiqdor)
        {
            return Quantity * sotilganMiqdor;
        }

        private void oldingiMiqdorNoReturn(int Quantity,int sotilganMiqdor)
        {
            resultVegetable = Quantity * sotilganMiqdor;
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

            public Flower (int shunchaQoldi, int firstCount,string place)
            {
                qoldi = shunchaQoldi;
                resultDifferenceCount(shunchaQoldi, firstCount);
                placeFlower(place);
            }

            private  void resultDifferenceCount (int shunchaQoldi, int firstCount) 
            {
                resultDifference = firstCount-shunchaQoldi;
            }
            private void placeFlower(string placeBorn)
            {
                place = placeBorn;
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
                 AgeDifference = AnimalAgeDifference(Age,userage);
            }

            private int AnimalAgeDifference(int Age, int userage)
            {
                return userage - Age;
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