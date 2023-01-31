

Console.Write("Введите номер дня недели: ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) {
	if (Day >= 6) {
		Console.Write("Выходной день");
	} else {
		Console.Write("Рабочий день");
	}
} else {
	Console.Write("Вводите правильно! от 1 до 7.");
}
