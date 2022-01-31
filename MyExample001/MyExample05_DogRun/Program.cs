Console.WriteLine("Сколько метров между друзьями?");
int distance = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какова скорость первого друга?");
int speed1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какова скорость второго друга?");
int speed2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("А скорость собаки?");
int dogspeed = Convert.ToInt32(Console.ReadLine());

int friend = 2;
int count = 0, 
    time = 0;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (speed1 + dogspeed);
        friend = 2;
    }
    else
    {
        time = distance / (speed2 + dogspeed);
        friend = 1;
    }
    distance = distance - (speed1 + speed2) * time;
    count++;
}

Console.WriteLine($"Собака успеет пробежать {count} раз");