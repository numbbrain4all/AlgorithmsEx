AlgorithmsEx On Cloud9
=============


### [Setting up and Using .NET ](http://stackoverflow.com/questions/25784490/does-cloud-9-support-net-for-build-or-deploy-or-debug)

### INSTALL PROCEDURE

1. Add the Mono Project GPG signing key and the package repository
    ```
    sudo apt-key adv --keyserver keyserver.ubuntu.com --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
    echo "deb http://download.mono-project.com/repo/debian wheezy main" | sudo tee /etc/apt/sources.list.d/mono-xamarin.list
    sudo apt-get update
    sudo apt-get update --fix-missing
    ```
2. Then install Mono as described

    ```
    sudo apt-get install mono-complete
    sudo apt-get install mono-devel
    sudo apt-get install referenceassemblies-pcl
    ```

### HOW COMPILE CONSOLE APPLICATION

1. To compile, use mcs:
    ```
    mcs filename.cs
    ```

2. The compiler will create filename.exe, which you can run using:
    ```
    mono filename.exe
    ```

### Using Python

```python
#!/usr/bin/python

print "Hello Python 2.X !!!";
```

```
>> python helloPython.py 
```

```python3
#!/usr/bin/python3

print ("Hello Python 3.X !!!");
```

```
>> python3 helloPython3.py 
```

### Using Java


### Using C/C++


