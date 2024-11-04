// ЗАВДАННЯ 2 (Керування чергою замовлень)


class Program
{
    static void Main()
    {
        // Створення черги для замовлень
        Queue<Order> orderQueue = new Queue<Order>();

        // Додавання замовлень до черги
        AddOrderToQueue(orderQueue, new Order("Order1", "Burger"));
        AddOrderToQueue(orderQueue, new Order("Order2", "Pizza"));
        AddOrderToQueue(orderQueue, new Order("Order3", "Salad"));

        // Виведення інформації про найстарше замовлення у черзі
        PrintOldestOrderInfo(orderQueue);

        // Видалення найстаршого замовлення з черги
        RemoveOldestOrder(orderQueue);

        // Виведення інформації про нове найстарше замовлення у черзі
        PrintOldestOrderInfo(orderQueue);
    }

    // Функція для додавання нового замовлення до черги
    static void AddOrderToQueue(Queue<Order> queue, Order order)
    {
        queue.Enqueue(order);
        Console.WriteLine($"Замовлення \"{order.OrderName}\" додано до черги.");
    }

    // Функція для видалення найстаршого замовлення з черги
    static void RemoveOldestOrder(Queue<Order> queue)
    {
        if (queue.Count > 0)
        {
            Order removedOrder = queue.Dequeue();
            Console.WriteLine($"Найстарше замовлення \"{removedOrder.OrderName}\" видалено з черги.");
        }
        else
        {
            Console.WriteLine("Черга замовлень порожня. Неможливо видалити замовлення.");
        }
    }

    // Функція для отримання найстаршого замовлення з черги без його видалення
    static void PrintOldestOrderInfo(Queue<Order> queue)
    {
        if (queue.Count > 0)
        {
            Order oldestOrder = queue.Peek();
            Console.WriteLine($"Інформація про найстарше замовлення: {oldestOrder}");
        }
        else
        {
            Console.WriteLine("Черга замовлень порожня. Неможливо отримати інформацію.");
        }
    }
}

// Клас, що представляє замовлення
class Order
{
    public string OrderName { get; set; }
    public string Item { get; set; }

    public Order(string orderName, string item)
    {
        OrderName = orderName;
        Item = item;
    }

    public override string ToString()
    {
        return $"Назва замовлення: {OrderName}, Позиція: {Item}";
    }
}