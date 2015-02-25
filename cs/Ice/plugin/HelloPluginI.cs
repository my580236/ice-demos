// **********************************************************************
//
// Copyright (c) 2003-2014 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************

public class HelloPluginI : Ice.Plugin
{
    public HelloPluginI(Ice.Communicator communicator)
    {
        _communicator = communicator;
    }

    public void initialize()
    {
        Ice.ObjectAdapter adapter = _communicator.createObjectAdapter("Hello");
        adapter.add(new HelloI(), _communicator.stringToIdentity("hello"));
        adapter.activate();
    }

    public void destroy()
    {
    }

    private Ice.Communicator _communicator;
}
