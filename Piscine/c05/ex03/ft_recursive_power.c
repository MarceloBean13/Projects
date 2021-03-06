/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_recursive_power.c                               :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/02 16:58:49 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/05 15:53:31 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

int		ft_recursive_power(int nb, int power)
{
	int res;

	res = 1;
	if (power < 0)
		return (0);
	if (nb == 0 && power == 0)
		return (1);
	if (power != 0)
	{
		res = nb * ft_recursive_power(nb, power - 1);
	}
	return (res);
}
