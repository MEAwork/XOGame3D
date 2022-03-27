﻿using System;
using System.Collections.Generic;
using XOGame3D.Enum;
using XOGame3D.Interfaces;

namespace XOGame3D.Logic
{
    public class TicTacToeController
    {
        private readonly TicTacToeLogic _logic;
        private readonly IUser _user1;
        private readonly IUser _user2;

        public TicTacToeLogic Play => _logic;

        public TicTacToeController(TicTacToeLogic logic, IUser user1, IUser user2)
        {
            _logic = logic;
            _user1 = user1;
            _user2 = user2;
            logic.SetWinner += Logic_SetWinner;
        }

        private void Logic_SetWinner(object sender, States e)
        {
            SetWinner?.Invoke(sender, e);
        }

        public void ChooseUserFraction(IUser user, States state)
        {
            if (_user1.Fraction != States.Empty || _user2.Fraction != States.Empty)
                throw new Exception("User state was choose");
            if (_user1 == user)
            {
                _user1.Fraction = state;
                _user2.Fraction = state == States.X ? States.O : States.X;
            }
            else
            {
                _user2.Fraction = state;
                _user1.Fraction = state == States.X ? States.O : States.X;
            }
        }

        public IUser GetCurrenUser()
        {
            if (_user1 == null || _user2 == null)
                throw new Exception("Not set user");
            if (_user1.Fraction == States.Empty || _user2.Fraction == States.Empty)
                throw new Exception("Not choose state");
            if (_user1.Fraction == _logic.CurrenState)
                return _user1;
            if (_user2.Fraction == _logic.CurrenState)
                return _user2;
            throw new Exception("Unpossible  return user");
        }

        public void MakeMove()
        {
            var currentUser = GetCurrenUser();
            if(_logic.GetCurrentArea() == null)
            {
                var areaCoordinate = currentUser.ChooseArea();
                _logic.SetCurrentArea(areaCoordinate);
            }
            var cellCoordinate = currentUser.ChooseCell();
            _logic.SetState(cellCoordinate);
        }

        public IArea GetCurrentArea() => _logic.GetCurrentArea();

        public IArea GetBigArea() => _logic.GetBigArea();

        public IArea GetAllSmallAreasByCell(ICell cell) => _logic.GetAllSmallAreasByCell(cell);

        public event EventHandler<States> SetWinner;
    }
}
