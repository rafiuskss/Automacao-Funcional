﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.utils
{
    class ClassInfo
    {
        private string logMessage;
        private bool resultScenario;
        private bool resultFeature = true;
        private static ClassInfo classInfoInstance;

        private ClassInfo()
        {

        }

        public static ClassInfo GetInstance()
        {
            if (classInfoInstance== null)
            {
                classInfoInstance = new ClassInfo();
            }

            return classInfoInstance;
        }

        public string LogMessage
        {
            get
            {
                return logMessage;
            }

            set
            {               
                logMessage = value;
            }

        }

        public bool ResultScenario
        {
            get
            {
                return resultScenario;
            }
            set
            {
                resultScenario = value;
                resultFeature = value == false ? false : true;
            }
        }

        public bool ResultFeature
        {
            get
            {
                return resultFeature;
            }
            set
            {
                resultFeature = value;
            }
        }

    }
}
