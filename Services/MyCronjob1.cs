using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using LibManage.Data;
using LibManage.Models;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LibManage.Services
{
    public class MyCronJob1 : CronJobService
    {
        private readonly ILogger<MyCronJob1> _logger;
        private IServiceScopeFactory serviceProvider;
        private IConfiguration configuration;
        public MyCronJob1(IScheduleConfig<MyCronJob1> config, ILogger<MyCronJob1> logger, IServiceScopeFactory serviceProvider, IConfiguration configuration)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
            this.configuration = configuration;
            this.serviceProvider = serviceProvider;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("START.");
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} RUN JOB UPDATE STATUS ORDER.");

            const int FEE_ON_DAY = 100;

            using (var scope = serviceProvider.CreateScope()) // this will use `IServiceScopeFactory` internally
            {
                var db = scope.ServiceProvider.GetService<ApplicationDbContext>();
                var orders = db.Orders.Where(item => item.Status != OrderStatus.Success && item.Status != OrderStatus.Dispose).ToList();
                var now = DateTime.Now;
                foreach (var item in orders)
                {
                    if (now > item.ToDate)
                    {
                        item.Status = OrderStatus.Overdue; // update status
                        item.PenaltyFee = 0;
                        var totalDayOverdueTimeSpan = now.Subtract(item.ToDate);
                        var totalDayOverdue = totalDayOverdueTimeSpan.Days;
                        
                        int index = 1; 
                        while(totalDayOverdue >= index){
                            index ++;
                            item.PenaltyFee += FEE_ON_DAY;
                        }

                    }
                }

                db.SaveChanges();
            }


            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CronJob STOPPPPPPPPPPP.");
            return base.StopAsync(cancellationToken);
        }
    }
}