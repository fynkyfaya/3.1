var n = int.Parse(Console.ReadLine());

double q = 0;
for (var k = 1; k <= n; k++) {

    var factorial = 1;
    for (var x = 1; x <= k + n; x++) factorial *= x;
    
    var numerator = Math.Pow(-1, k) * (k - 7);
    
    var result = numerator / factorial;
    if (result == 0 || double.IsInfinity(result)) continue;
    
    q += result;
}

Console.WriteLine(q.ToString("F5"));