using System;

namespace Life
{
    class Program
    {
        abstract class Animal
        {
            //implementaqcion en el abtract animal los metodos para las clases de que usaran las herencias de animal
            public abstract void animalSound();
            public abstract void animalType();
            public abstract void animalAction();
            // metodos que todas las clases heredadas hacen igualmente
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
            public void eat()
            {
                Console.WriteLine("YUM YUM");
            }

        }
        //implementacion de clases
        class dog : Animal
        {
            public override void animalType()
            {
                Console.WriteLine("Mamifero");
            }
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("wow wow");
            }
            public override void animalAction()
            {
                Console.WriteLine("* correr");
            }

        }
        class cat : Animal
        {
            public override void animalType()
            {
                Console.WriteLine("Mamifero");
            }
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("meow meow");
            }
            public override void animalAction()
            {
                Console.WriteLine("* agazaparse");
            }
        }
        class capibara : Animal
        {
            public override void animalType()
            {
                Console.WriteLine("Mamifero");
            }
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine(" HAAAAAA HAAAAA");
            }
            public override void animalAction()
            {
                Console.WriteLine("* se sonroja");
            }
        }


        static void Main(string[] args)
        {
            //aplicacion de crear cualquier animal en base de las clases heredadas con sus metodos de "ANIMAL" y propios
            Console.WriteLine("DOG");
            dog dogi = new dog();
            dogi.animalType();
            dogi.animalSound();
            dogi.sleep();
            dogi.animalAction();
            dogi.eat();
            Console.WriteLine("CAT");
            cat cattt = new cat();
            cattt.animalType();
            cattt.animalSound();
            cattt.sleep();
            cattt.animalAction();
            cattt.eat();
            Console.WriteLine("Capibara");
            capibara capi = new capibara();
            capi.animalType();
            capi.animalSound();
            capi.sleep();
            capi.animalAction();
            capi.eat();

        }


    }
}