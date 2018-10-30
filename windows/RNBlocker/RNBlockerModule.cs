using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Blocker.RNBlocker
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBlockerModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBlockerModule"/>.
        /// </summary>
        internal RNBlockerModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBlocker";
            }
        }
    }
}
