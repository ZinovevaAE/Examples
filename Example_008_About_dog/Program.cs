//Задача. Два друга и собака
//два друга идут в одну сторону (первый догоняет второго, собака изначально бежит от первого ко второму, 
//встретятся, когда расстояние между друзьями <10)

Console.Write("Введите скорость собаки: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость первого человека (должна быть больше скорости второго): ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость второго человека: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите расстояние: ");
int distance = Convert.ToInt32(Console.ReadLine());

int count = 0;
int friend = 2;
int time = 0;

while (distance >= 10)
{
    if (friend == 2)
    {
        time = distance / (dogSpeed - secondFriendSpeed);
        friend = 1;
    }
    else
    {
        time = distance / (dogSpeed + firstFriendSpeed);
        friend = 2;
    }
    distance = distance - firstFriendSpeed * time + secondFriendSpeed * time;
    count = count + 1;
}

Console.Write(count);
Console.WriteLine(" times");