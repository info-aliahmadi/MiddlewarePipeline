<Query Kind="Program" />

void Main()
{
	Wrap(First);
	Wrap(Second);
}

// You can define other methods, fields, classes and namespaces here

public void First(){
	"First".Dump();
}
public void Second(){
	"Second".Dump();
}
public void Wrap(Action function){
	"start".Dump();
	function();
	"end".Dump();
}
public void Try(Action function){
	"try".Dump();
	function();
	"end try".Dump();
}