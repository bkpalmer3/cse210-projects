public class Scripture
{
    private Reference _reference;
    private Verse _verse;

public Scripture(Reference reference, Verse verse)
{
    _reference = reference;
    _verse = verse;
}

public void DisplayScripture()
{
    _reference.DisplayReference();
    _verse.DisplayVerse();
}

}
