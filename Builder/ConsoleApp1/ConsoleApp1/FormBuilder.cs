using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FormBuilder
{
    private Form form;
    private WelcomeMessageBuilder welcomeMessageBuilder;
    private ButtonsBuilder buttonsBuilder;
    public FormBuilder() 
    {
        reset();
    }
    private void reset()
    {
        form = new Form();
    }
    public void setButtonsBuilder(ButtonsBuilder buttonsBuilder)
    {
        this.buttonsBuilder = buttonsBuilder;
    }
    public void setWMBuilder(WelcomeMessageBuilder welcomeMessageBuilder)
    {
        this.welcomeMessageBuilder = welcomeMessageBuilder;
    }
    public void constructForm()
    {
        form._welcomeMessage = this.welcomeMessageBuilder.printWM();
        form._buttons.Add(this.buttonsBuilder.addButton());
    }
    public Form getForm()
    {
        return form;
    }
    
}

