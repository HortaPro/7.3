//Анастасия Миронова 22-ИСП-2/1
//7.3 уровень высокий; вариант 4

Console.Write("Введите число заметок: ");
var notesNumber = int.Parse(Console.ReadLine());

var blockNote = new Note[notesNumber];
for (var noteIndex = 0; noteIndex < notesNumber; noteIndex++)
{
    Console.Write("\nВведите имя: ");
    var noteName = Console.ReadLine()!;

    Console.Write("Введите номер телефона: ");
    var notePhone = Console.ReadLine()!;

    Console.Write("Введите дату рождения в формате DD.MM.YYYY: ");
    var noteDate = DateOnly.Parse(Console.ReadLine()!);

    blockNote[noteIndex] = new Note(noteName, notePhone, noteDate);
}

var sorted = blockNote.OrderBy(note => note.date);

try
{
    Console.Write("\nВведите номер телефона человека: ");
    var phoneToSearch = Console.ReadLine()!;

    var note = sorted.First(note => note.tele == teleToSearch);
    Console.WriteLine(note);
}
catch (InvalidOperationException)
{
    Console.WriteLine("В заметках не найден человек с указанным номером телефона.");
}


internal struct Note
{
    private string name;
    public string tele;
    public DateOnly date;

    public Note(string name, string tele, DateOnly date)
    {
        this.name = name;
        this.tele = tele;
        this.date = date;
    }

    public override string ToString()
    {
        return $"\n{name}:\n- Номер телефона: {tele}\n- Дата рождения: {date}";
    }
}
