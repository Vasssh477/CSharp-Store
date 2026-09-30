int selectedItem;
string[] nameTov = new string[6] {"Хлеб", "Молоко", "Сыр", "Колбаса", "Шоколад", "Чай"};
int[] priceTov = new int[6] {60, 90, 250, 320, 120, 180 };
int[] balanceTov = new int[6] {10, 7, 4, 6, 8, 5};

do
{
    Console.WriteLine("======== МАГАЗИН ========\n" +
        "\n"+
        "1. Показать товары\n" +
        "2. Купить товар\n" +
        "3. Пополнить склад\n" +
        "4. Статистика\n" +
        "5. Найти товар\n" +
        "0. Выход");
    Console.WriteLine();
    Console.WriteLine("Выберите пункт меню: ");
    selectedItem = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (selectedItem)
    {
        case 1:
            ShowTov(nameTov, priceTov, balanceTov);
            break;
        case 2:
            BuyTov(nameTov, priceTov, balanceTov);
            break;
        case 3:
            AddTov(nameTov, balanceTov);
            break;
        case 4:
            StatisticsTov(nameTov, priceTov, balanceTov);
            break;
        case 5:
            SearchTov(nameTov, priceTov, balanceTov);
            break;
        case 0:
            Console.WriteLine("До встречи!");
            break;
        default:
            Console.WriteLine("Не корректно выбран пункт меню!");
            break;
    }
}
while (selectedItem != 0);
static void ShowTov(string[] nameTov, int[] priceTov, int[] balanceTov)
{
    Console.WriteLine("======== ТОВАРЫ ========");
    for (int i = 0; i < nameTov.Length; i++)
    {
        Console.WriteLine($"{i + 1}.{nameTov[i],-10} {priceTov[i],-3} руб.Остаток: {balanceTov[i],3}");
    }
    Console.WriteLine();
}
static void BuyTov(string[] nameTov, int[] priceTov, int[] balanceTov)
{
    Console.WriteLine("Введите название товара для покупки: ");
    string nameBuyTov = Console.ReadLine();
    Console.WriteLine("Введите количество товара для покупки: ");
    int countBuyTov = int.Parse(Console.ReadLine());
    int costTov = 0;
    bool found = false;
    for (int i = 0; i < nameTov.Length; i++)
    {
        if (nameBuyTov == nameTov[i])
        {
            found = true;
            if (countBuyTov <= balanceTov[i] && countBuyTov > 0)
            {
                balanceTov[i] -= countBuyTov;
                costTov = countBuyTov * priceTov[i];
                Console.WriteLine("Покупка удалась!\n" +
                    $"Товар: {nameTov[i]}\n" +
                    $"Количество: {countBuyTov}\n" +
                    $"Остаток: {balanceTov[i]}\n" +
                    $"Стоимость: {costTov} руб.");
                break;
            }
            else
            {
                Console.WriteLine("Количество введенно не корректно!");
                break;
            }
        }
    }
    if (!found)
    {
        Console.WriteLine("Товар не найден!");
    }
    Console.WriteLine();
}
static void AddTov(string[] nameTov, int[] balanceTov)
{
    Console.WriteLine("Введите номер товара: ");
    int numTov = int.Parse(Console.ReadLine());
    int temp = 0;
    bool found = false;
    for (int i = 0; i < nameTov.Length; i++)
    {
        if (numTov == i + 1)
        {
            found = true;
            Console.WriteLine("Введите количество: ");
            int countAddTov = int.Parse(Console.ReadLine());
            if (countAddTov > 0)
            {
                temp = balanceTov[i];
                balanceTov[i] += countAddTov;
                Console.WriteLine(nameTov[i] + "\n" +
                $"Было: {temp}\n" +
                $"Добавить: {countAddTov}\n" +
                $"Стало: {balanceTov[i]}");
                break;
            }
            else
            {
                Console.WriteLine("Количество должно быть больше 0!");
                break;
            }
        }
    }
    if (!found)
    {
        Console.WriteLine("Товар не найден!");
    }
    Console.WriteLine();
}
static void StatisticsTov(string[] nameTov, int[] priceTov, int[] balanceTov)
{
    int sum = 0;
    int averagePrice = 0;
    for (int i = 0; i < priceTov.Length; i++)
    {
        sum += priceTov[i];
    }
    averagePrice = sum / priceTov.Length;
    Console.WriteLine($"Средняя стоимость всех товаров: {averagePrice}");
    Console.WriteLine();
}
static void SearchTov(string[] nameTov, int[] priceTov, int[] balanceTov)
{
    Console.WriteLine("Введите название товара для поиска: ");
    string search = Console.ReadLine();
    bool found = false;
    for (int i = 0; i < nameTov.Length; i++)
    {
        if (search == nameTov[i])
        {
            found = true;
            Console.WriteLine($"Товар найден: \n" +
                $"\n" +
                $"Название: {nameTov[i]}\n" +
                $"Цена: {priceTov[i]} руб.\n" +
                $"Остаток: {balanceTov[i]} ед.");
            break;
        }
    }
    if (!found)
    {
        Console.WriteLine("Товар не найден");
    }
    Console.WriteLine();
}