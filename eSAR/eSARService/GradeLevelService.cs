using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARLogic;
using eSARBDO;
namespace eSARService
{
    public class GradeLevelService : IGradeLevelService
    {
        GradeLevelLogic glogic = new GradeLevelLogic();
        public List<GradeLevel> GetAllGradeLevels()
        {
            List<GradeLevelBDO> glBDOList = glogic.GetAllGradeLevels();
            List<GradeLevel> glList = new List<GradeLevel>();
            foreach (GradeLevelBDO glBDo in glBDOList)
            {
                GradeLevel g = new GradeLevel();
                TranslateeGradeLevelBDOToeGradeLevelDTo(glBDo, g);
                glList.Add(g);
            }
            return glList;
        }

        public void TranslateGradeLevelToGradeLevelBDO(GradeLevel gl, GradeLevelBDO g) {
            FeeService fs = new FeeService();
            TraitService ts = new TraitService();
            g.Description = gl.Description;
            g.GradeLev = gl.GradeLev;
            g.StudentFees = fs.ToFeeBDOList(gl.StudentFees);
            g.Traits = ts.ToTraitBDOList(gl.Traits);
        }

        private void TranslateeGradeLevelBDOToeGradeLevelDTo(GradeLevelBDO glBDO, GradeLevel gradeLevel)
        {
            gradeLevel.Description = glBDO.Description;
            gradeLevel.GradeLev = glBDO.GradeLev;
            //TO DO Fee and Service
        }
    }
}
