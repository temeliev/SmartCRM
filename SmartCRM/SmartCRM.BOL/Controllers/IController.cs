namespace SmartCRM.BOL.Controllers
{
    using System;

    public interface IController
    {
        event EventHandler Changed;
    }
}
