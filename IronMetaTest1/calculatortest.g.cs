//
// IronMeta calculatorTest Parser; Generated 2015-12-17 15:17:45Z UTC
//

using System;
using System.Collections.Generic;
using System.Linq;

using IronMeta.Matcher;

#pragma warning disable 0219
#pragma warning disable 1591

namespace IronMetaTest1
{

    using _calculatorTest_Inputs = IEnumerable<char>;
    using _calculatorTest_Results = IEnumerable<double>;
    using _calculatorTest_Item = IronMeta.Matcher.MatchItem<char, double>;
    using _calculatorTest_Args = IEnumerable<IronMeta.Matcher.MatchItem<char, double>>;
    using _calculatorTest_Memo = IronMeta.Matcher.MatchState<char, double>;
    using _calculatorTest_Rule = System.Action<IronMeta.Matcher.MatchState<char, double>, int, IEnumerable<IronMeta.Matcher.MatchItem<char, double>>>;
    using _calculatorTest_Base = IronMeta.Matcher.Matcher<char, double>;

    public partial class calculatorTest : IronMeta.Matcher.Matcher<char, double>
    {
        public calculatorTest()
            : base()
        {
            _setTerminals();
        }

        public calculatorTest(bool handle_left_recursion)
            : base(handle_left_recursion)
        {
            _setTerminals();
        }

        void _setTerminals()
        {
            this.Terminals = new HashSet<string>()
            {
                "DecimalDigit",
                "DS",
                "Expression",
                "WS",
            };
        }


        public void Expression(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // CALLORVAR Additive
            _calculatorTest_Item _r0;

            _r0 = _MemoCall(_memo, "Additive", _index, Additive, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void Additive(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // OR 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // CALLORVAR Add
            _calculatorTest_Item _r2;

            _r2 = _MemoCall(_memo, "Add", _index, Add, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // CALLORVAR Sub
            _calculatorTest_Item _r3;

            _r3 = _MemoCall(_memo, "Sub", _index, Sub, null);

            if (_r3 != null) _index = _r3.NextIndex;

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // CALLORVAR Multiplicative
            _calculatorTest_Item _r4;

            _r4 = _MemoCall(_memo, "Multiplicative", _index, Multiplicative, null);

            if (_r4 != null) _index = _r4.NextIndex;

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void Add(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // CALL BinaryOp
            var _start_i1 = _index;
            _calculatorTest_Item _r1;
            var _arg1_0 = '+';

            _r1 = _MemoCall(_memo, "BinaryOp", _index, BinaryOp, new _calculatorTest_Item[] { new _calculatorTest_Item(Additive), new _calculatorTest_Item(_arg1_0), new _calculatorTest_Item(Multiplicative) });

            if (_r1 != null) _index = _r1.NextIndex;

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { double a = _IM_Result.Results.ToList()[0];
             double b = _IM_Result.Results.ToList()[1];
             Console.WriteLine("Adding Decimals {0} + {1} = {2}",a,b,a+b);
             return a+b; }, _r0), true) );
            }

        }


        public void Sub(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // CALL BinaryOp
            var _start_i1 = _index;
            _calculatorTest_Item _r1;
            var _arg1_0 = '-';

            _r1 = _MemoCall(_memo, "BinaryOp", _index, BinaryOp, new _calculatorTest_Item[] { new _calculatorTest_Item(Additive), new _calculatorTest_Item(_arg1_0), new _calculatorTest_Item(Multiplicative) });

            if (_r1 != null) _index = _r1.NextIndex;

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { double a = _IM_Result.Results.ToList()[0];
             double b = _IM_Result.Results.ToList()[1];
             Console.WriteLine("Subtracting Decimals {0} - {1} = {2}",a,b,a-b);
             return a-b; }, _r0), true) );
            }

        }


        public void Multiplicative(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // OR 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // CALLORVAR Multiply
            _calculatorTest_Item _r2;

            _r2 = _MemoCall(_memo, "Multiply", _index, Multiply, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // CALLORVAR Divide
            _calculatorTest_Item _r3;

            _r3 = _MemoCall(_memo, "Divide", _index, Divide, null);

            if (_r3 != null) _index = _r3.NextIndex;

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // CALLORVAR Decimals
            _calculatorTest_Item _r4;

            _r4 = _MemoCall(_memo, "Decimals", _index, Decimals, null);

            if (_r4 != null) _index = _r4.NextIndex;

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void Multiply(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // CALL BinaryOp
            var _start_i1 = _index;
            _calculatorTest_Item _r1;
            var _arg1_0 = "*";

            _r1 = _MemoCall(_memo, "BinaryOp", _index, BinaryOp, new _calculatorTest_Item[] { new _calculatorTest_Item(Multiplicative), new _calculatorTest_Item(_arg1_0), new _calculatorTest_Item(Decimals) });

            if (_r1 != null) _index = _r1.NextIndex;

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { double a = _IM_Result.Results.ToList()[0];
             double b = _IM_Result.Results.ToList()[1];
             Console.WriteLine("Multiplying Decimal {0} * {1} = {2}",a,b, a*b);
             return a*b; }, _r0), true) );
            }

        }


        public void Divide(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // CALL BinaryOp
            var _start_i1 = _index;
            _calculatorTest_Item _r1;
            var _arg1_0 = "/";

            _r1 = _MemoCall(_memo, "BinaryOp", _index, BinaryOp, new _calculatorTest_Item[] { new _calculatorTest_Item(Multiplicative), new _calculatorTest_Item(_arg1_0), new _calculatorTest_Item(Decimals) });

            if (_r1 != null) _index = _r1.NextIndex;

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { double a = _IM_Result.Results.ToList()[0];
             double b = _IM_Result.Results.ToList()[1];
             Console.WriteLine("Dividing Decimal {0} / {1} = {2}",a,b, a/b);
             return a/b; }, _r0), true) );
            }

        }


        public void Decimals(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // OR 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // CALLORVAR CombineBinary
            _calculatorTest_Item _r2;

            _r2 = _MemoCall(_memo, "CombineBinary", _index, CombineBinary, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // CALLORVAR CombineUnary
            _calculatorTest_Item _r3;

            _r3 = _MemoCall(_memo, "CombineUnary", _index, CombineUnary, null);

            if (_r3 != null) _index = _r3.NextIndex;

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // CALL Number
            var _start_i4 = _index;
            _calculatorTest_Item _r4;

            _r4 = _MemoCall(_memo, "Number", _index, Number, new _calculatorTest_Item[] { new _calculatorTest_Item(DecimalDigit) });

            if (_r4 != null) _index = _r4.NextIndex;

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void CombineBinary(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // CALL BinaryOp
            var _start_i1 = _index;
            _calculatorTest_Item _r1;

            _r1 = _MemoCall(_memo, "BinaryOp", _index, BinaryOp, new _calculatorTest_Item[] { new _calculatorTest_Item(Decimals), new _calculatorTest_Item(DS), new _calculatorTest_Item(Number), new _calculatorTest_Item(DecimalDigit) });

            if (_r1 != null) _index = _r1.NextIndex;

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { double a = _IM_Result.Results.ToList()[0];
             double b = _IM_Result.Results.ToList()[1];
             Console.WriteLine("Combining Decimal {0} - {1} = {2}",a,b,a.ToString() + "," + b.ToString());
             while (b>1) { b /= 10; }
             return a+b; }, _r0), true) );
            }

        }


        public void CombineUnary(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // CALL UnaryOp
            var _start_i1 = _index;
            _calculatorTest_Item _r1;

            _r1 = _MemoCall(_memo, "UnaryOp", _index, UnaryOp, new _calculatorTest_Item[] { new _calculatorTest_Item(DS), new _calculatorTest_Item(Number), new _calculatorTest_Item(DecimalDigit) });

            if (_r1 != null) _index = _r1.NextIndex;

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { double a = _IM_Result.Results.ToList()[0];
             Console.WriteLine("Unary Decimal {0} = {1}",a,"0," + a.ToString());
             while (a>1) { a /= 10; }
             return a; }, _r0), true) );
            }

        }


        public void BinaryOp(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _calculatorTest_Item first = null;
            _calculatorTest_Item op = null;
            _calculatorTest_Item second = null;
            _calculatorTest_Item type = null;
            _calculatorTest_Item a = null;
            _calculatorTest_Item b = null;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // AND 1
            int _start_i1 = _arg_index;

            // AND 2
            int _start_i2 = _arg_index;

            // AND 3
            int _start_i3 = _arg_index;

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND first
            first = _memo.ArgResults.Peek();

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label3; }

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND op
            op = _memo.ArgResults.Peek();

        label3: // AND
            var _r3_2 = _memo.ArgResults.Pop();
            var _r3_1 = _memo.ArgResults.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.ArgResults.Push(new _calculatorTest_Item(_start_i3, _arg_index, _r3_1.Inputs.Concat(_r3_2.Inputs), _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i3;
            }

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label2; }

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND second
            second = _memo.ArgResults.Peek();

        label2: // AND
            var _r2_2 = _memo.ArgResults.Pop();
            var _r2_1 = _memo.ArgResults.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.ArgResults.Push(new _calculatorTest_Item(_start_i2, _arg_index, _r2_1.Inputs.Concat(_r2_2.Inputs), _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i2;
            }

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label1; }

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // QUES
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Pop(); _memo.ArgResults.Push(new _calculatorTest_Item(_arg_index, _memo.InputEnumerable)); }

            // BIND type
            type = _memo.ArgResults.Peek();

        label1: // AND
            var _r1_2 = _memo.ArgResults.Pop();
            var _r1_1 = _memo.ArgResults.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.ArgResults.Push(new _calculatorTest_Item(_start_i1, _arg_index, _r1_1.Inputs.Concat(_r1_2.Inputs), _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i1;
            }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 14
            int _start_i14 = _index;

            // AND 15
            int _start_i15 = _index;

            // CALLORVAR first
            _calculatorTest_Item _r17;

            if (first.Production != null)
            {
                var _p17 = (System.Action<_calculatorTest_Memo, int, IEnumerable<_calculatorTest_Item>>)(object)first.Production; // what type safety?
                _r17 = _MemoCall(_memo, first.Production.Method.Name, _index, _p17, null);
            }
            else
            {
                _r17 = _ParseLiteralObj(_memo, ref _index, first.Inputs);
            }

            if (_r17 != null) _index = _r17.NextIndex;

            // BIND a
            a = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label15; }

            // CALL KW
            var _start_i18 = _index;
            _calculatorTest_Item _r18;

            _r18 = _MemoCall(_memo, "KW", _index, KW, new _calculatorTest_Item[] { op });

            if (_r18 != null) _index = _r18.NextIndex;

        label15: // AND
            var _r15_2 = _memo.Results.Pop();
            var _r15_1 = _memo.Results.Pop();

            if (_r15_1 != null && _r15_2 != null)
            {
                _memo.Results.Push( new _calculatorTest_Item(_start_i15, _index, _memo.InputEnumerable, _r15_1.Results.Concat(_r15_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i15;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label14; }

            // CALL second
            var _start_i20 = _index;
            _calculatorTest_Item _r20;

            _r20 = _MemoCall(_memo, second.ProductionName, _index, second.Production, new _calculatorTest_Item[] { type });

            if (_r20 != null) _index = _r20.NextIndex;

            // BIND b
            b = _memo.Results.Peek();

        label14: // AND
            var _r14_2 = _memo.Results.Pop();
            var _r14_1 = _memo.Results.Pop();

            if (_r14_1 != null && _r14_2 != null)
            {
                _memo.Results.Push( new _calculatorTest_Item(_start_i14, _index, _memo.InputEnumerable, _r14_1.Results.Concat(_r14_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i14;
            }

            // ACT
            var _r13 = _memo.Results.Peek();
            if (_r13 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r13.StartIndex, _r13.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return new List<double> { a, b }; }, _r13), true) );
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void UnaryOp(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _calculatorTest_Item op = null;
            _calculatorTest_Item second = null;
            _calculatorTest_Item type = null;
            _calculatorTest_Item b = null;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // AND 1
            int _start_i1 = _arg_index;

            // AND 2
            int _start_i2 = _arg_index;

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND op
            op = _memo.ArgResults.Peek();

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label2; }

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND second
            second = _memo.ArgResults.Peek();

        label2: // AND
            var _r2_2 = _memo.ArgResults.Pop();
            var _r2_1 = _memo.ArgResults.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.ArgResults.Push(new _calculatorTest_Item(_start_i2, _arg_index, _r2_1.Inputs.Concat(_r2_2.Inputs), _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i2;
            }

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label1; }

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // QUES
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Pop(); _memo.ArgResults.Push(new _calculatorTest_Item(_arg_index, _memo.InputEnumerable)); }

            // BIND type
            type = _memo.ArgResults.Peek();

        label1: // AND
            var _r1_2 = _memo.ArgResults.Pop();
            var _r1_1 = _memo.ArgResults.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.ArgResults.Push(new _calculatorTest_Item(_start_i1, _arg_index, _r1_1.Inputs.Concat(_r1_2.Inputs), _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i1;
            }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 11
            int _start_i11 = _index;

            // CALL KW
            var _start_i12 = _index;
            _calculatorTest_Item _r12;

            _r12 = _MemoCall(_memo, "KW", _index, KW, new _calculatorTest_Item[] { op });

            if (_r12 != null) _index = _r12.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label11; }

            // CALL second
            var _start_i14 = _index;
            _calculatorTest_Item _r14;

            _r14 = _MemoCall(_memo, second.ProductionName, _index, second.Production, new _calculatorTest_Item[] { type });

            if (_r14 != null) _index = _r14.NextIndex;

            // BIND b
            b = _memo.Results.Peek();

        label11: // AND
            var _r11_2 = _memo.Results.Pop();
            var _r11_1 = _memo.Results.Pop();

            if (_r11_1 != null && _r11_2 != null)
            {
                _memo.Results.Push( new _calculatorTest_Item(_start_i11, _index, _memo.InputEnumerable, _r11_1.Results.Concat(_r11_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i11;
            }

            // ACT
            var _r10 = _memo.Results.Peek();
            if (_r10 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r10.StartIndex, _r10.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return b; }, _r10), true) );
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void Number(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _calculatorTest_Item type = null;
            _calculatorTest_Item n = null;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND type
            type = _memo.ArgResults.Peek();

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 4
            int _start_i4 = _index;

            // CALL Digits
            var _start_i6 = _index;
            _calculatorTest_Item _r6;

            _r6 = _MemoCall(_memo, "Digits", _index, Digits, new _calculatorTest_Item[] { type });

            if (_r6 != null) _index = _r6.NextIndex;

            // BIND n
            n = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // STAR 7
            int _start_i7 = _index;
            var _res7 = Enumerable.Empty<double>();
        label7:

            // CALLORVAR WS
            _calculatorTest_Item _r8;

            _r8 = _MemoCall(_memo, "WS", _index, WS, null);

            if (_r8 != null) _index = _r8.NextIndex;

            // STAR 7
            var _r7 = _memo.Results.Pop();
            if (_r7 != null)
            {
                _res7 = _res7.Concat(_r7.Results);
                goto label7;
            }
            else
            {
                _memo.Results.Push(new _calculatorTest_Item(_start_i7, _index, _memo.InputEnumerable, _res7.Where(_NON_NULL), true));
            }

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _calculatorTest_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // ACT
            var _r3 = _memo.Results.Peek();
            if (_r3 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r3.StartIndex, _r3.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { Console.WriteLine("Read {0}", (char)n); return n; }, _r3), true) );
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void Digits(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _calculatorTest_Item type = null;
            _calculatorTest_Item a = null;
            _calculatorTest_Item b = null;

            // OR 0
            int _start_i0 = _index;

            // ARGS 1
            _arg_index = 0;
            _arg_input_index = 0;

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND type
            type = _memo.ArgResults.Peek();

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label1;
            }

            // AND 5
            int _start_i5 = _index;

            // CALL Digits
            var _start_i7 = _index;
            _calculatorTest_Item _r7;

            _r7 = _MemoCall(_memo, "Digits", _index, Digits, new _calculatorTest_Item[] { type });

            if (_r7 != null) _index = _r7.NextIndex;

            // BIND a
            a = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label5; }

            // CALLORVAR type
            _calculatorTest_Item _r9;

            if (type.Production != null)
            {
                var _p9 = (System.Action<_calculatorTest_Memo, int, IEnumerable<_calculatorTest_Item>>)(object)type.Production; // what type safety?
                _r9 = _MemoCall(_memo, type.Production.Method.Name, _index, _p9, null);
            }
            else
            {
                _r9 = _ParseLiteralObj(_memo, ref _index, type.Inputs);
            }

            if (_r9 != null) _index = _r9.NextIndex;

            // BIND b
            b = _memo.Results.Peek();

        label5: // AND
            var _r5_2 = _memo.Results.Pop();
            var _r5_1 = _memo.Results.Pop();

            if (_r5_1 != null && _r5_2 != null)
            {
                _memo.Results.Push( new _calculatorTest_Item(_start_i5, _index, _memo.InputEnumerable, _r5_1.Results.Concat(_r5_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i5;
            }

            // ACT
            var _r4 = _memo.Results.Peek();
            if (_r4 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r4.StartIndex, _r4.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return (double)a*10+(double)b; }, _r4), true) );
            }

        label1: // ARGS 1
            _arg_input_index = _arg_index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // ARGS 10
            _arg_index = 0;
            _arg_input_index = 0;

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND type
            type = _memo.ArgResults.Peek();

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label10;
            }

            // CALLORVAR type
            _calculatorTest_Item _r13;

            if (type.Production != null)
            {
                var _p13 = (System.Action<_calculatorTest_Memo, int, IEnumerable<_calculatorTest_Item>>)(object)type.Production; // what type safety?
                _r13 = _MemoCall(_memo, type.Production.Method.Name, _index, _p13, null);
            }
            else
            {
                _r13 = _ParseLiteralObj(_memo, ref _index, type.Inputs);
            }

            if (_r13 != null) _index = _r13.NextIndex;

        label10: // ARGS 10
            _arg_input_index = _arg_index; // no-op for label

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void DecimalDigit(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            _calculatorTest_Item c = null;

            // INPUT CLASS
            _ParseInputClass(_memo, ref _index, '\u0030', '\u0031', '\u0032', '\u0033', '\u0034', '\u0035', '\u0036', '\u0037', '\u0038', '\u0039');

            // BIND c
            c = _memo.Results.Peek();

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _calculatorTest_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return (char)c - '0'; }, _r0), true) );
            }

        }


        public void KW(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _calculatorTest_Item str = null;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND str
            str = _memo.ArgResults.Peek();

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 3
            int _start_i3 = _index;

            // CALLORVAR str
            _calculatorTest_Item _r4;

            if (str.Production != null)
            {
                var _p4 = (System.Action<_calculatorTest_Memo, int, IEnumerable<_calculatorTest_Item>>)(object)str.Production; // what type safety?
                _r4 = _MemoCall(_memo, str.Production.Method.Name, _index, _p4, null);
            }
            else
            {
                _r4 = _ParseLiteralObj(_memo, ref _index, str.Inputs);
            }

            if (_r4 != null) _index = _r4.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // STAR 5
            int _start_i5 = _index;
            var _res5 = Enumerable.Empty<double>();
        label5:

            // CALLORVAR WS
            _calculatorTest_Item _r6;

            _r6 = _MemoCall(_memo, "WS", _index, WS, null);

            if (_r6 != null) _index = _r6.NextIndex;

            // STAR 5
            var _r5 = _memo.Results.Pop();
            if (_r5 != null)
            {
                _res5 = _res5.Concat(_r5.Results);
                goto label5;
            }
            else
            {
                _memo.Results.Push(new _calculatorTest_Item(_start_i5, _index, _memo.InputEnumerable, _res5.Where(_NON_NULL), true));
            }

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _calculatorTest_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void DS(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // OR 0
            int _start_i0 = _index;

            // LITERAL '.'
            _ParseLiteralChar(_memo, ref _index, '.');

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL ','
            _ParseLiteralChar(_memo, ref _index, ',');

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void WS(_calculatorTest_Memo _memo, int _index, _calculatorTest_Args _args)
        {

            // OR 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // OR 2
            int _start_i2 = _index;

            // LITERAL ' '
            _ParseLiteralChar(_memo, ref _index, ' ');

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i2; } else goto label2;

            // LITERAL '\n'
            _ParseLiteralChar(_memo, ref _index, '\n');

        label2: // OR
            int _dummy_i2 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // LITERAL '\r'
            _ParseLiteralChar(_memo, ref _index, '\r');

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL '\t'
            _ParseLiteralChar(_memo, ref _index, '\t');

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


    } // class calculatorTest

} // namespace IronMetaTest1

