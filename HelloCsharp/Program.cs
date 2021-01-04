using System;

namespace HelloCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("佘桢澄写的第一行Csharp代码");
            // var str = "这是一个字符串";
            // Console.Write(str);
            // Console.ReadKey();

            // 类型强制转换
            // int i = 75;
            // float f = 53.2121212f;
            // double d = 2345.23456;
            // bool b = true;

            // Console.WriteLine(i.ToString());
            // Console.WriteLine(f.ToString());
            // Console.WriteLine(d.ToString());
            // Console.WriteLine(b.ToString());

            // var abc = b.ToString();
            // Console.WriteLine(abc);

            // switch case语句
            // Console.WriteLine("请输入您的成绩");
            // int score;
            // try {
            //     score = Convert.ToInt32(Convert.ToDouble(Console.ReadLine()));
            //     switch (score/10) {
            //         case 10:
            //             Console.WriteLine("优秀");
            //             break;
            //         case 9:
            //         case 8:
            //             Console.WriteLine("良好");
            //             break;
            //         case 7:
            //         case 6:
            //             Console.WriteLine("合格了");
            //             break;
            //         default:
            //             Console.WriteLine("没有及格呦");
            //             break;
            //     }
            // }
            // catch {
            //     Console.WriteLine("处理异常信息");
            // }


            // for循环 (实现九九乘法表)
            // for (int i = 1; i <= 9; i++) {
            //     for (int x = 1; x <= i; x++) {
            //         Console.WriteLine(i + "*" + x + "=" + i * x + "\t");
            //     }
            // }
           

            // while循环（while循环一般适用于不固定次数的循环）
            // int i = 1;
            // int sum = 0;
            // while (i <= 10) {
            //     sum += i;
            //     Console.WriteLine(i);
            //     i++;
            // }
            // Console.WriteLine(sum);


            // do while循环（do while循环可以说是while循环的另一个版本，与while循环最大的区别是它至少会执行一次）
            // int i = 1;
            // int sum = 0;
            // do {
            //     Console.WriteLine(i);
            //     sum += i;
            //     i++;
            // }
            // while (i <= 10);
            // Console.WriteLine(sum);


            // break的用法
            // for (int i = 1;i < 10; i++) {
            //     if (i == 4) {
            //         Console.WriteLine("打住了");
            //         break;
            //     }
            //     Console.WriteLine(i);
            // }


            // continue的用法（continue语句有点像break，但是它不是强制终止，continue会跳过当前循环中的代码，强制开始下一次循环）
            // 对于for循环，continue语句会导致执行条件测试和循环增量部分。对于while和do while循环，continue语句会导致程序控制回到条件测试上。
            // for (int i = 1;i < 10; i++) {
            //     if (i == 5) {
            //         Console.WriteLine("i等于5了，但是我想继续");
            //         continue;
            //     }
            //     Console.WriteLine(i);
            // }


            // goto语句（goto语句用于直接在一个程序中转到程序中的标签指定的位置，标签实际上由标识符加上冒号构成。）
            // 如果要跳转到某一个标签指定的位置，直接使用goto加标签名即可
            int count = 1;
            login:
                Console.WriteLine("请输入用户名");
                string userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                string passWord = Console.ReadLine();
                if (userName == "佘桢澄" && passWord == "123") {
                    Console.WriteLine("登陆成功");
                } else {
                    count ++;
                    if (count > 3) {
                        Console.WriteLine("输了个啥？！！");
                    } else {
                        Console.WriteLine("用户名称或密码错误");
                        goto login;
                    }
                }
        }
    }
}
