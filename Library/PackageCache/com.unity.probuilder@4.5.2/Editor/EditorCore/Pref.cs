<<<<<<< HEAD
using UnityEditor.SettingsManagement;

namespace UnityEditor.ProBuilder
{
    sealed class Pref<T> : UserSetting<T>
    {
        public Pref(string key, T value, SettingsScope scope = SettingsScope.Project)
            : base(ProBuilderSettings.instance, key, value, scope)
        {}

        public Pref(Settings settings, string key, T value, SettingsScope scope = SettingsScope.Project)
            : base(settings, key, value, scope) {}

        public static implicit operator T(Pref<T> pref)
        {
            return pref.value;
        }
    }
}
=======
using UnityEditor.SettingsManagement;

namespace UnityEditor.ProBuilder
{
    sealed class Pref<T> : UserSetting<T>
    {
        public Pref(string key, T value, SettingsScope scope = SettingsScope.Project)
            : base(ProBuilderSettings.instance, key, value, scope)
        {}

        public Pref(Settings settings, string key, T value, SettingsScope scope = SettingsScope.Project)
            : base(settings, key, value, scope) {}

        public static implicit operator T(Pref<T> pref)
        {
            return pref.value;
        }
    }
}
>>>>>>> 7cf0e2f442837203eb7c741f38b2f438425c3367
