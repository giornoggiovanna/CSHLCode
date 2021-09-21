var n = [];

n[0] = prompt();

n[1] = prompt();

n[2] = prompt();

var a;

n.forEach(increment(a, n));

function increment(a, b)
{
    a++;

    console.log(b[a]);

}
