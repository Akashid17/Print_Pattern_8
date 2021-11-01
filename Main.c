
#include<stdio.h>

void Display(int iNo1, int iNo2)
{
    if(iNo1 < 0)
    {
        iNo1 = -iNo1;
    }

    if(iNo2 < 0)
    {
        iNo2 = -iNo2;
    }

    for(int i = 1; i <= iNo1; i++)
    {
        for(int j = 1; j <= iNo2; j++)
        {
            printf("*\t");
        }
        printf("\n");
    }
}

int main()
{
    int iValue1 = 0, iValue2 = 0;

    printf("Enter Count of Rows and Columns\n");
    scanf("%d%d",&iValue1,&iValue2);

    Display(iValue1,iValue2);

    return 0;
}