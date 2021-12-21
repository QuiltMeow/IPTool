using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPLookUp
{
	[Obsolete("已有 C 實作版本 參考 IPSearcher.dll")]
	public class QQWry
	{
		private const string CODE_PAGE = "GB2312";
		
		private readonly byte[] database;
		private readonly uint indexHead, indexTail;

		public QQWry(string file)
		{
			database = File.ReadAllBytes(file);
			indexHead = readItem<uint>(0);
			indexTail = readItem<uint>(4);
		}

		public (string, string) queryIP(string ip)
		{
			if (!IPUtil.isIPv4(ip))
            {
				return ("IP 格式錯誤或不支援 IPv6 查詢", string.Empty);
            }

			string[] ipItem = ip.Split('.');
			uint ipNumber = (Convert.ToUInt32(ipItem[0]) << 24) | (Convert.ToUInt32(ipItem[1]) << 16) | (Convert.ToUInt32(ipItem[2]) << 8) | Convert.ToUInt32(ipItem[3]);
			
			uint head = indexHead;
			uint tail = indexTail;
			while (tail > head)
			{
				uint cursor = ((tail - head) / 7) >> 1;
				cursor = head + (cursor == 0 ? 1 : cursor) * 7;
				
				uint ipMin = readItem<uint>(cursor);
				uint position = readItem<uint>(cursor + 4) & 0xFFFFFF;
				uint ipMax = readItem<uint>(position);
				if (ipNumber < ipMin)
				{
					tail = cursor;
				}
				else if (ipNumber > ipMax)
				{
					head = cursor;
				}
				else
				{
					position += 4;
					byte mode = database[position];
					if (mode == 0x01)
					{
						uint mainOffset = readItem<uint>(position + 1) & 0xFFFFFF;
						if (database[mainOffset] == 0x02)
						{
							return readInformation(mainOffset, position + 8);
						}
						else
						{
							return readInformation(mainOffset);
						}
					}
					else if (mode == 0x02)
					{
						uint mainOffset = readItem<uint>(position + 1) & 0xFFFFFF;
						return readInformation(mainOffset, position + 4);
					}
					else
					{
						return readInformation(position);
					}
				}
			}
			return (string.Empty, string.Empty);
		}

		private (string, string) readInformation(uint mainPosition, uint subPosition = 0)
		{
			string mainInformation = readItem<string>(mainPosition);
			subPosition = subPosition == 0 ? (mainPosition + (uint)Encoding.GetEncoding(CODE_PAGE).GetByteCount(mainInformation)) : subPosition;
			string subInformation = readItem<string>(subPosition);
			return (mainInformation, subInformation);
		}

		private T readItem<T>(uint position)
		{
			if (typeof(T) == typeof(uint))
			{
				uint ret = database[position] + (((uint)database[position + 1]) << 8) + (((uint)database[position + 2]) << 16) + (((uint)database[position + 3]) << 24);
				return (T)(object)ret;
			}
			else if (typeof(T) == typeof(string))
			{
				IList<byte> ret = new List<byte>();
				if (database[position] == 0x01 || database[position] == 0x02)
				{
					position = readItem<uint>(position + 1) & 0xFFFFFF;
					if (database[position] >= 0x00 && database[position] <= 0x02)
					{
						return (T)(object)string.Empty;
					}
				}
				while (database[position] != 0x00)
				{
					ret.Add(database[position++]);
				}
				return (T)(object)Encoding.GetEncoding(CODE_PAGE).GetString(ret.ToArray());
			}
			throw new Exception("型別不支援");
		}
	}
}