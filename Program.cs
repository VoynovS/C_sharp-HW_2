// See https://aka.ms/new-console-template for more information
using C_sharp_HW_2;

List<Uchastniki> uchastniki = new List<Uchastniki>();

int count = Uchastniki.Vvod_age("Введите количество участников: ");

for (int i = 0; i < count; i++) {
    uchastniki.Add(new Uchastniki(i + 1));
}

void vyvod() {
    Console.WriteLine("Все участники:");

    foreach (var item in uchastniki) {
        Console.WriteLine(item.ToString());
    }
}
Console.WriteLine();
vyvod();
Console.WriteLine();
Console.WriteLine("[1] Добавить участника");
Console.WriteLine("[2] Удалить участника");
Console.WriteLine("[3] Изменить возраст");
Console.WriteLine("[4] Изменить ФИО");

switch (Console.ReadLine()) {
    case "1": 
        uchastniki.Add(new Uchastniki(uchastniki.Count));
        Console.WriteLine();
        vyvod();
        break;        
    case "2":
        Console.WriteLine("Введите ID участника: ");
        uchastniki.RemoveAt(Uchastniki.Vvod_age("") - 1);
        Console.WriteLine();
        vyvod();
        break;
    case "3":
        Console.WriteLine("Введите ID участника: ");
        int _age = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Введите новый возраст: ");
        (uchastniki.ElementAt(_age)).Age = int.Parse(Console.ReadLine());
        Console.WriteLine();
        vyvod();
        break;
    case "4":
        Console.WriteLine("Введите ID участника: ");
        int _name = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Введите новое ФИО: ");
        uchastniki.ElementAt(_name).Name = String.Format(Console.ReadLine());
        Console.WriteLine();
        vyvod();
        break;

    default: {
            break;
        }
}
