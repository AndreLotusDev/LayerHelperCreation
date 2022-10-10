using LayerHelperCreation.Factory;

namespace LayerHelperCreation.Shared
{
    public class Injectable
    {
        public T Resolve<T>()
        {
            return InstanceFactory.GetInstance<T>();
        }
    }

    public class InjectableForm : Form
    {
        public Injectable Injectable = new Injectable();
    }
}
