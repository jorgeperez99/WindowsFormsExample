﻿using System.ServiceModel;

namespace Host {
    [ServiceContract]
    public interface ICalculator {
        [OperationContract]
        double Add(double a, double b);
        [OperationContract]
        double Subtract(double a, double b);
    }
}