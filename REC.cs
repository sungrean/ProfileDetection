using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using static ProfileDetection.Protocol;

[StructLayout(LayoutKind.Sequential, Pack = 4)]	
public struct PIC_SIZE_T{
	public UInt32 x, y;
};

namespace ProfileDetection
{
    public class REC
    {
        public const int PIX_NUM = 128;                        //行像素数量
        public const int IMG_HEIGHT = 100;                     //图片高度
        public const int BYTES_PER_IMG_LINE = (PIX_NUM / 8);   //每行字节数
        public const int DWORDS_PER_IMG_LINE = (PIX_NUM / 32); //每行UInt32数
        public const double PIX_SIZE = 0.127;         		//200dpi  25.4/200

        REC_ITEM curRec = new REC_ITEM();

        public REC_ITEM RecFrameDeal(COMM_FRAME_T frm)
        {
            curRec = (REC_ITEM)BytesToStruct(frm.data, Marshal.SizeOf(typeof(REC_ITEM)), typeof(REC_ITEM));

            //IntPtr buff = (IntPtr)(new byte[Marshal.SizeOf(typeof(REC_ITEM))]);

            //check record data
            //curRec.valid = true;
            //if dataerror set curRec.valid to false

            return curRec;
        }

        //BytesToStruct
        public object BytesToStruct(byte[] buf, int len, Type type)
        {
            object rtn;
            IntPtr buffer = Marshal.AllocHGlobal(len);
            Marshal.Copy(buf, 0, buffer, len);
            rtn = Marshal.PtrToStructure(buffer, type);
            Marshal.FreeHGlobal(buffer);
            return rtn;
        }

    }
}
