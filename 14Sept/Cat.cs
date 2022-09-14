class Cat //klassen
{
    public string name;    //class field
    public int age;
    private bool isInsured = false;
    public Cat(string name, int age)    //Konstruktor för Cat-klassen
    {
        this.name = name;   //this syftar på DEN HÄR KLASSEN
        this.age = age;
    }

    public bool SetToInsured()
    {
        if (name == "")
            return isInsured;
        else
        return isInsured = true;
    }


    //nedan behöver inte användas då name är public, hade den varit private hade vi kunnat använda nedan metod
    //public string GetName()
    //{
    //    return name;
    //}
}