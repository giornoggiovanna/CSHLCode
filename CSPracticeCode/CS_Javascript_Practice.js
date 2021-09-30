var a_a = [2,1,4,7,3,12];
var i_flag = 0;
var a_b = [];

function swap()
{

    for(var i = 0; i < a_a.length; i++)
    {

        var i_tempv1;
        var i_tempv2;

        if(a_a[i] > a_a[i+1])
        {

            a_a[i] = i_tempv1;
            a_a[i+1] = i_tempv2;

            a_b[i+1] = i_tempv1;
            a_b[i] = i_tempv2;

        }
        if(a_a[i+1] == null) 
        {
        break;
        }

        console.log(a_b[i]);

    }

}

swap();