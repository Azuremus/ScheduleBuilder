using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ScheduBuild
{
    internal class HtmlBuild
    {
        public void WriteDiv(Personnel[] allTutors, string quarter)
        {
            Console.WriteLine(@"    
				< div >
					< script >
						function schedules(idName) {
						var x = document.getElementsByClassName('subject');
						for (i = 0; i < x.length; i++)
						{
							x[i].style.display = 'none';
						}
						document.getElementById(idName).style.display = '';
						}
					</ script >
			");

            Console.WriteLine($@"

						< h2 > The below schedules are for <strong>{quarter} </strong> quarter.</ h2 >
			");

			//for (int i = 0; i < allTutors.Subs.Length; i++) { }
            
			Console.WriteLine($@"
                                    < button type = 'button' onclick = 'schedules('stats')' > Statistics </ button >
            

                                    < button type = 'button' onclick = 'schedules('math')' > Math </ button >
            

                                    < button type = 'button' onclick = 'schedules('english')' > English </ button >
            


                                    < table id = 'stats' class='subject' style='display:none; '>
							<caption>	Statistics</caption>									
							<tr>																
								<th>	Name</th>
								<th>	Monday</th>
								<th>	Tuesday</th>
								<th>	Wednesday</th>
								<th>	Thursday</th>
								<th>	Friday</th>
								<th>	Saturday</th>	
							</tr>																
								<td>	Ryan</td><td>	&nbsp</td><td>	&nbsp</td><td>	&nbsp</td><td>	11:30-04:30	</td><td>	&nbsp</td><th>	&nbsp</td>	
							<tr>																
								<td>	Dion</td><td>	09:00-11:00	</td><td>	09:00-11:00	</td><td>	09:00-11:00	</td><td>	09:00-11:00	</td><td>	&nbsp</td><td>	&nbsp</td>	
							/tr>																
						</table>
			
	
	
	
				</div>
			");
        }
}
}
