FormBuilder fBuilder = new FormBuilder();
StudentsButtonsBuilder bBuilder = new StudentsButtonsBuilder();
StudentsWMBuilder wmBuilder = new StudentsWMBuilder();
fBuilder.setButtonsBuilder(bBuilder);
fBuilder.setWMBuilder(wmBuilder);
fBuilder.constructForm();
Form form = fBuilder.getForm();
Console.WriteLine(form._welcomeMessage);
Console.WriteLine(form._buttons.FirstOrDefault());
        