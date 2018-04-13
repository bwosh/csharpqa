using ClassSamples;

namespace ClassSamples
{
    // Create class Person
    internal class Person
    {
        // Person has Age and Name (properties)
        public string Name { get; set; }

        public int Age { get; set; }

        // create constructor that takes name and age
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // make pretty ToString() method
        public override string ToString()
        {
            return string.Format("name:{0} age:{1}", Name, Age);
        }
    }
}


internal class Guild
{
    public string Name { get; set; }
    public Person[] GuildMembers { get; set; }

    public Guild(string name, Person[] guildMembers)
    {
        Name = name;
        GuildMembers = guildMembers;
    }

    public void AddNewMember(Person newMember)
    {
        // Create new table with 1 more space
        Person[] newArray = new Person[GuildMembers.Length + 1];
        for (int i = 0; i < GuildMembers.Length; i++)
        {
            newArray[i] = GuildMembers[i];
        }

        // Add new person at the end of table
        newArray[GuildMembers.Length] = newMember;

        // Replace class property with new value
        GuildMembers = newArray;
    }

    public void RemoveMemberAtIndex(int index)
    {
        Person[] newArray = new Person[GuildMembers.Length - 1];

        // Rewrite all people below index
        for (int i = 0; i < index; i++)
        {
            newArray[i] = GuildMembers[i];
        }

        // Reweite all people over index (with index change)
        for (int i = index+1; i < GuildMembers.Length; i++)
        {
            newArray[i-1] = GuildMembers[i];
        }

        GuildMembers = newArray;
    }
}



// HOMEWORK
// next: count number of people under 18 (method with Person[] arrayOfPerson)
// next: find name of oldest person (method with Person[] arrayOfPerson)
// next: print average age of people (method with Person[] arrayOfPerson)

// next: create Group of people class (GroupName, Person[])
// next: group: write Group.Add method & UT
// next: group: write Group.Remove method & UT

// next: every person in every-group should have Nickname
// next: nicknnames shold be unique across Group