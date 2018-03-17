using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
  class Ball
  {
    private int x, y;
    private int dx, dy;

    public int GetX()
    {
      return x;
    }

    public void SetX(int x)
    {
      this.x = x;
    }
  }
}
