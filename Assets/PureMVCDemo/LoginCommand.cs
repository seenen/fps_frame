﻿using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Patterns.Command;

public class LoginCommand : SimpleCommand {

    public override void Execute (PureMVC.Interfaces.INotification notification)
    {
        Debug.Log ("LoginCommand");
        object obj = notification.Body;
        LoginProxy loginProxy; 
        loginProxy = Facade.RetrieveProxy (LoginProxy.NAME) as LoginProxy;
        string name = notification.Name;


        if (NotiConst.S_LOGIN == name)
        {
            loginProxy.sendLogin (obj);
        }
    }
}