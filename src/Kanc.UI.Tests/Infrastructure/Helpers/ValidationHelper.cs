using System.Windows.Forms;
using NHibernate.Validator.Binding;
using Environment = NHibernate.Validator.Cfg.Environment;

namespace Kanc.UI.Tests.Core
{
    public class ValidationHelper
    {
        public static SmartViewValidator CreateValidator(ErrorProvider errorProvider)
        {
            //ValidatorEngine = Environment.SharedEngineProvider.GetEngine()
            return new SmartViewValidator(errorProvider) {ErrorProvider = errorProvider};
        }
    }
}
