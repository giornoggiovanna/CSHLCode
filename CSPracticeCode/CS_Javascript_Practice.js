var n = [10, 342, 54, 28, 5, 433];

var nl = a.length;

for (i=1; i<nl; i++)
{


    var a; 
    var b;  
    var c;

    

    if(i = 1)
    {
        a = n[i];
        b = n[i++];
        
        if (a>b) c = a;
        else c = b;

        return c;
    }else
    {

        a = n[i];

        if(a>c) a = c;

    }

    return c

    }

console.log(c);