namespace Shop.UIForms.Infraestructure
{
    using Shop.UIForms.ViewModels;
    class InstanceLocator
    {
        public  MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

    }
}
