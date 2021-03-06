/*
 * Copyright (c) 2020 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pedometer.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Pedometer
{
    /// <summary>
    /// Main class of Pedometer
    /// Inherits from Xamarin.Forms.Application
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes Pedometer class instance
        /// </summary>
        public App()
        {
            MainPage = new WelcomePage();
        }
    }
}