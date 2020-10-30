﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    class Problem:Content
    {
        private string _title { get; set; }
        private string _body { get; set; }

        public Problem(string body) //每一个Problem对象一定有Body赋值
        {
            _body = body;
        }

        private Problem()
        {
        }

        private int _reward; //problem.Reward不能为负数
        public int _Reward
        {
            get { return _reward; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("悬赏数不能为负数");
                    return;
                }
            }
        }

        private DateTime _publishDateTime { get; set; }
        private User _author { get; set; }

        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。

        private string[] _keywords = new string[10];
        public string this[int index]
        {
            set { _keywords[index - 1] = value; }
            get { return _keywords[index - 1]; }
        }

        public override void publish()
        {
            base.publish();
            Console.WriteLine();
        }
    }
}
