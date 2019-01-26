using AutoMapper;
using CustomerCloud.DTOs;
using CustomerCloud.Entities;
using CustomerCloud.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LogicTest
{
    [TestClass]
    public class OrderDetailTests
    {

        public void Create()
        {
            Mapper.Reset();
            OrderDetailDTO order = CreateOrderDetail();
            BaseLogic<OrderDetailEntity, OrderDetailDTO> logic = new BaseLogic<OrderDetailEntity, OrderDetailDTO>();
            logic.Create(order);
            OrderDetailDTO result = logic.Read(order.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual(order.Id, result.Id);
        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        private OrderDetailDTO CreateOrderDetail()
        {
            return new OrderDetailDTO()
            {
                Id = Guid.NewGuid()
            };
        }
    }
}
