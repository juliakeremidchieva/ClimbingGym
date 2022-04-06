using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ClimbingGym.ModelBinders
{
    public class DateTimeModelBinderProvider : IModelBinderProvider
    {
        private readonly string customeDateFormat;
        public DateTimeModelBinderProvider(string _customeDateFormat)
        {
            customeDateFormat = _customeDateFormat;
        }
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(DateTime) || context.Metadata.ModelType == typeof(DateTime?))
            {
                return new DateTimeModelBinder(customeDateFormat);
            }
            return null;
        }
    }
}
