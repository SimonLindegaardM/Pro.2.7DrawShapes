namespace DrawShapes
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // SHAPE A (10 stars in a single row)
            //
            // **********
            //
            for (int a = 1; a <=10; a++)
            {
                DrawingTool.DrawOneStar();
            }
            System.Console.WriteLine();

            // SHAPE B (5 stars in a single row, separated by spaces)
            //
            // * * * * * 
            //
            for (int b = 1; b <=5; b++)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneSpace();
            }
            System.Console.WriteLine();

            // SHAPE C  (10 rows of 10 stars each)
            //
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            //
            for (int c = 1; c <= 10; c++)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.StartNewLine();
            }

            // SHAPE D (a triangle, I guess...)
            //
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            //
            for (int d = 1; d <=10; d++)
            {
                for (int dd = 1; dd<=d; dd++)
                {
                    DrawingTool.DrawOneStar();
                }
                DrawingTool.StartNewLine();
            }

            // SHAPE E (X)
            //
            // *        *
            //  *      * 
            //   *    *   
            //    *  *    
            //     **     
            //     **     
            //    *  *    
            //   *    *   
            //  *      * 
            // *        *
            for (int cc = 0; cc < 10; cc++)
            {
                for (int r = 0; r < 10; r++)
                {
                    if(cc==r || cc + r ==9)
                    {
                        DrawingTool.DrawOneStar();
                    }
                    else
                    {
                        DrawingTool.DrawOneSpace();
                    }
                }
                DrawingTool.StartNewLine(); 
            }



            // The LAST line of code should be ABOVE this line

        }
    }
}