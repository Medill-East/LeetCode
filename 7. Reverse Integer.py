class Solution:
    def reverse(self, x: int) -> int:
      # 1.[ : :-1]可以将字符串翻转
      # 2.rstrip()返回删除字符串末尾的指定字符后生成的新字符串
      s = str(x)[::-1].rstrip('-')
      if int(s) < 2**31:
        if x >= 0:
          return int(s)
        else:
          return 0-int(s)
      else:
        return 0
